<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncProjectRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ding89233847892ndkas
     *
     * @var string
     */
    public $channelCorpId;

    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $costCenterId;

    /**
     * @var bool
     */
    public $deleteFlag;

    /**
     * @var string
     */
    public $extension;

    /**
     * @description This parameter is required.
     *
     * @example 2022-02-21 11:11:11
     *
     * @var string
     */
    public $gmtAction;

    /**
     * @var string
     */
    public $invoiceId;

    /**
     * @var string[]
     */
    public $managerIds;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $projectId;

    /**
     * @description This parameter is required.
     *
     * @example 默认项目
     *
     * @var string
     */
    public $projectName;

    /**
     * @example 1
     *
     * @var int
     */
    public $scope;

    /**
     * @var string
     */
    public $source;

    /**
     * @var string
     */
    public $thirdPartId;

    /**
     * @description This parameter is required.
     *
     * @example 20881001829000
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'channelCorpId' => 'channelCorpId',
        'code' => 'code',
        'costCenterId' => 'costCenterId',
        'deleteFlag' => 'deleteFlag',
        'extension' => 'extension',
        'gmtAction' => 'gmtAction',
        'invoiceId' => 'invoiceId',
        'managerIds' => 'managerIds',
        'projectId' => 'projectId',
        'projectName' => 'projectName',
        'scope' => 'scope',
        'source' => 'source',
        'thirdPartId' => 'thirdPartId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelCorpId) {
            $res['channelCorpId'] = $this->channelCorpId;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->costCenterId) {
            $res['costCenterId'] = $this->costCenterId;
        }
        if (null !== $this->deleteFlag) {
            $res['deleteFlag'] = $this->deleteFlag;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->gmtAction) {
            $res['gmtAction'] = $this->gmtAction;
        }
        if (null !== $this->invoiceId) {
            $res['invoiceId'] = $this->invoiceId;
        }
        if (null !== $this->managerIds) {
            $res['managerIds'] = $this->managerIds;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->projectName) {
            $res['projectName'] = $this->projectName;
        }
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->thirdPartId) {
            $res['thirdPartId'] = $this->thirdPartId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncProjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelCorpId'])) {
            $model->channelCorpId = $map['channelCorpId'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['costCenterId'])) {
            $model->costCenterId = $map['costCenterId'];
        }
        if (isset($map['deleteFlag'])) {
            $model->deleteFlag = $map['deleteFlag'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['gmtAction'])) {
            $model->gmtAction = $map['gmtAction'];
        }
        if (isset($map['invoiceId'])) {
            $model->invoiceId = $map['invoiceId'];
        }
        if (isset($map['managerIds'])) {
            if (!empty($map['managerIds'])) {
                $model->managerIds = $map['managerIds'];
            }
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['projectName'])) {
            $model->projectName = $map['projectName'];
        }
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['thirdPartId'])) {
            $model->thirdPartId = $map['thirdPartId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
