<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdatePublishAuditResultResponseBody extends Model
{
    /**
     * @var bool
     */
    public $accepted;

    /**
     * @var string
     */
    public $auditId;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'accepted' => 'accepted',
        'auditId' => 'auditId',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accepted) {
            $res['accepted'] = $this->accepted;
        }
        if (null !== $this->auditId) {
            $res['auditId'] = $this->auditId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePublishAuditResultResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accepted'])) {
            $model->accepted = $map['accepted'];
        }
        if (isset($map['auditId'])) {
            $model->auditId = $map['auditId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
