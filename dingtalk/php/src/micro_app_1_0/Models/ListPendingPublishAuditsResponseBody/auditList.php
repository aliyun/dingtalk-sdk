<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListPendingPublishAuditsResponseBody;

use AlibabaCloud\Tea\Model;

class auditList extends Model
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
    public $corpId;

    /**
     * @var string
     */
    public $creatorUserId;

    /**
     * @var int
     */
    public $sceneType;

    /**
     * @var int
     */
    public $status;

    /**
     * @var int
     */
    public $submitTime;

    /**
     * @var string
     */
    public $versionId;
    protected $_name = [
        'agentId' => 'agentId',
        'auditId' => 'auditId',
        'corpId' => 'corpId',
        'creatorUserId' => 'creatorUserId',
        'sceneType' => 'sceneType',
        'status' => 'status',
        'submitTime' => 'submitTime',
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
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->sceneType) {
            $res['sceneType'] = $this->sceneType;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->submitTime) {
            $res['submitTime'] = $this->submitTime;
        }
        if (null !== $this->versionId) {
            $res['versionId'] = $this->versionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return auditList
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['sceneType'])) {
            $model->sceneType = $map['sceneType'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['submitTime'])) {
            $model->submitTime = $map['submitTime'];
        }
        if (isset($map['versionId'])) {
            $model->versionId = $map['versionId'];
        }

        return $model;
    }
}
