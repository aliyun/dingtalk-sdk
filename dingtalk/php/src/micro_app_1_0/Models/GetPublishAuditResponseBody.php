<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetPublishAuditResponseBody\audit;
use AlibabaCloud\Tea\Model;

class GetPublishAuditResponseBody extends Model
{
    /**
     * @var audit
     */
    public $audit;
    protected $_name = [
        'audit' => 'audit',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->audit) {
            $res['audit'] = null !== $this->audit ? $this->audit->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPublishAuditResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['audit'])) {
            $model->audit = audit::fromMap($map['audit']);
        }

        return $model;
    }
}
