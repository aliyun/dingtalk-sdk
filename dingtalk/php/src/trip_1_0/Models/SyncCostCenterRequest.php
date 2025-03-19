<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncCostCenterRequest extends Model
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
     * @description This parameter is required.
     *
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
     * @example 123456
     *
     * @var string
     */
    public $number;

    /**
     * @example 1
     *
     * @var int
     */
    public $scope;

    /**
     * @example 阿里商旅
     *
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
     * @example 默认成本中心
     *
     * @var string
     */
    public $title;

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
        'costCenterId' => 'costCenterId',
        'deleteFlag' => 'deleteFlag',
        'extension' => 'extension',
        'gmtAction' => 'gmtAction',
        'number' => 'number',
        'scope' => 'scope',
        'source' => 'source',
        'thirdPartId' => 'thirdPartId',
        'title' => 'title',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelCorpId) {
            $res['channelCorpId'] = $this->channelCorpId;
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
        if (null !== $this->number) {
            $res['number'] = $this->number;
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
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncCostCenterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelCorpId'])) {
            $model->channelCorpId = $map['channelCorpId'];
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
        if (isset($map['number'])) {
            $model->number = $map['number'];
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
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
