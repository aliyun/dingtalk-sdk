<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncInvoiceRequest extends Model
{
    /**
     * @var string
     */
    public $address;

    /**
     * @example xxx银行
     *
     * @var string
     */
    public $bankName;

    /**
     * @var string
     */
    public $bankNo;

    /**
     * @description This parameter is required.
     *
     * @example ding89233847892ndkas
     *
     * @var string
     */
    public $channelCorpId;

    /**
     * @var bool
     */
    public $deleteFlag;

    /**
     * @description This parameter is required.
     *
     * @example 2022-02-21 11:11:11
     *
     * @var string
     */
    public $gmtAction;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $invoiceId;

    /**
     * @var string[]
     */
    public $projectIds;

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
    public $taxNo;

    /**
     * @var string
     */
    public $tel;

    /**
     * @example 123456
     *
     * @var string
     */
    public $thirdPartId;

    /**
     * @description This parameter is required.
     *
     * @example 默认发票抬头
     *
     * @var string
     */
    public $title;

    /**
     * @var int
     */
    public $type;

    /**
     * @var int
     */
    public $unitType;

    /**
     * @description This parameter is required.
     *
     * @example 20881001829000
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'address' => 'address',
        'bankName' => 'bankName',
        'bankNo' => 'bankNo',
        'channelCorpId' => 'channelCorpId',
        'deleteFlag' => 'deleteFlag',
        'gmtAction' => 'gmtAction',
        'invoiceId' => 'invoiceId',
        'projectIds' => 'projectIds',
        'scope' => 'scope',
        'source' => 'source',
        'taxNo' => 'taxNo',
        'tel' => 'tel',
        'thirdPartId' => 'thirdPartId',
        'title' => 'title',
        'type' => 'type',
        'unitType' => 'unitType',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }
        if (null !== $this->bankNo) {
            $res['bankNo'] = $this->bankNo;
        }
        if (null !== $this->channelCorpId) {
            $res['channelCorpId'] = $this->channelCorpId;
        }
        if (null !== $this->deleteFlag) {
            $res['deleteFlag'] = $this->deleteFlag;
        }
        if (null !== $this->gmtAction) {
            $res['gmtAction'] = $this->gmtAction;
        }
        if (null !== $this->invoiceId) {
            $res['invoiceId'] = $this->invoiceId;
        }
        if (null !== $this->projectIds) {
            $res['projectIds'] = $this->projectIds;
        }
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->taxNo) {
            $res['taxNo'] = $this->taxNo;
        }
        if (null !== $this->tel) {
            $res['tel'] = $this->tel;
        }
        if (null !== $this->thirdPartId) {
            $res['thirdPartId'] = $this->thirdPartId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->unitType) {
            $res['unitType'] = $this->unitType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncInvoiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }
        if (isset($map['bankNo'])) {
            $model->bankNo = $map['bankNo'];
        }
        if (isset($map['channelCorpId'])) {
            $model->channelCorpId = $map['channelCorpId'];
        }
        if (isset($map['deleteFlag'])) {
            $model->deleteFlag = $map['deleteFlag'];
        }
        if (isset($map['gmtAction'])) {
            $model->gmtAction = $map['gmtAction'];
        }
        if (isset($map['invoiceId'])) {
            $model->invoiceId = $map['invoiceId'];
        }
        if (isset($map['projectIds'])) {
            if (!empty($map['projectIds'])) {
                $model->projectIds = $map['projectIds'];
            }
        }
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['taxNo'])) {
            $model->taxNo = $map['taxNo'];
        }
        if (isset($map['tel'])) {
            $model->tel = $map['tel'];
        }
        if (isset($map['thirdPartId'])) {
            $model->thirdPartId = $map['thirdPartId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['unitType'])) {
            $model->unitType = $map['unitType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
