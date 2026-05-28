<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetPublishAuditResponseBody;

use AlibabaCloud\Tea\Model;

class audit extends Model
{
    /**
     * @var string
     */
    public $agentId;

    /**
     * @var string
     */
    public $appIcon;

    /**
     * @var string
     */
    public $appName;

    /**
     * @var string
     */
    public $approvalContent;

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
     * @var string
     */
    public $releaseNote;

    /**
     * @var int
     */
    public $sceneType;

    /**
     * @var int
     */
    public $status;

    /**
     * @var string
     */
    public $submitTime;

    /**
     * @var string
     */
    public $version;

    /**
     * @var string
     */
    public $versionDetailUrl;

    /**
     * @var string
     */
    public $versionId;
    protected $_name = [
        'agentId' => 'agentId',
        'appIcon' => 'appIcon',
        'appName' => 'appName',
        'approvalContent' => 'approvalContent',
        'auditId' => 'auditId',
        'corpId' => 'corpId',
        'creatorUserId' => 'creatorUserId',
        'releaseNote' => 'releaseNote',
        'sceneType' => 'sceneType',
        'status' => 'status',
        'submitTime' => 'submitTime',
        'version' => 'version',
        'versionDetailUrl' => 'versionDetailUrl',
        'versionId' => 'versionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->appIcon) {
            $res['appIcon'] = $this->appIcon;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->approvalContent) {
            $res['approvalContent'] = $this->approvalContent;
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
        if (null !== $this->releaseNote) {
            $res['releaseNote'] = $this->releaseNote;
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
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }
        if (null !== $this->versionDetailUrl) {
            $res['versionDetailUrl'] = $this->versionDetailUrl;
        }
        if (null !== $this->versionId) {
            $res['versionId'] = $this->versionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return audit
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['appIcon'])) {
            $model->appIcon = $map['appIcon'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['approvalContent'])) {
            $model->approvalContent = $map['approvalContent'];
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
        if (isset($map['releaseNote'])) {
            $model->releaseNote = $map['releaseNote'];
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
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['versionDetailUrl'])) {
            $model->versionDetailUrl = $map['versionDetailUrl'];
        }
        if (isset($map['versionId'])) {
            $model->versionId = $map['versionId'];
        }

        return $model;
    }
}
