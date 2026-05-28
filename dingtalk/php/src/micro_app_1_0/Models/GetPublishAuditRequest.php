<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPublishAuditRequest extends Model
{
    /**
     * @var string
     */
    public $auditId;
    protected $_name = [
        'auditId' => 'auditId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->auditId) {
            $res['auditId'] = $this->auditId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPublishAuditRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['auditId'])) {
            $model->auditId = $map['auditId'];
        }

        return $model;
    }
}
