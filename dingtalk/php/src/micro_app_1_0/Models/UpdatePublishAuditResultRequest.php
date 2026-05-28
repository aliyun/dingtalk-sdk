<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdatePublishAuditResultRequest extends Model
{
    /**
     * @var string
     */
    public $agentId;

    /**
     * @var string
     */
    public $auditId;

    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var string
     */
    public $rejectReason;

    /**
     * @var int
     */
    public $status;

    /**
     * @var string
     */
    public $versionId;
    protected $_name = [
        'agentId' => 'agentId',
        'auditId' => 'auditId',
        'operatorId' => 'operatorId',
        'rejectReason' => 'rejectReason',
        'status' => 'status',
        'versionId' => 'versionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->auditId) {
            $res['auditId'] = $this->auditId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->rejectReason) {
            $res['rejectReason'] = $this->rejectReason;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->versionId) {
            $res['versionId'] = $this->versionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePublishAuditResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['auditId'])) {
            $model->auditId = $map['auditId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['rejectReason'])) {
            $model->rejectReason = $map['rejectReason'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['versionId'])) {
            $model->versionId = $map['versionId'];
        }

        return $model;
    }
}
