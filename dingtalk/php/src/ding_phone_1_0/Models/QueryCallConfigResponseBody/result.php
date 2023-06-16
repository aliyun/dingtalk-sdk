<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\QueryCallConfigResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $accountDomain;

    /**
     * @var string
     */
    public $accountId;

    /**
     * @var int
     */
    public $callInType;

    /**
     * @var int
     */
    public $callOutType;

    /**
     * @var string
     */
    public $createUid;

    /**
     * @var string
     */
    public $phoneNumber;

    /**
     * @var string
     */
    public $scopeType;

    /**
     * @var int
     */
    public $showType;

    /**
     * @var string
     */
    public $sourceType;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'accountDomain' => 'accountDomain',
        'accountId'     => 'accountId',
        'callInType'    => 'callInType',
        'callOutType'   => 'callOutType',
        'createUid'     => 'createUid',
        'phoneNumber'   => 'phoneNumber',
        'scopeType'     => 'scopeType',
        'showType'      => 'showType',
        'sourceType'    => 'sourceType',
        'status'        => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountDomain) {
            $res['accountDomain'] = $this->accountDomain;
        }
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->callInType) {
            $res['callInType'] = $this->callInType;
        }
        if (null !== $this->callOutType) {
            $res['callOutType'] = $this->callOutType;
        }
        if (null !== $this->createUid) {
            $res['createUid'] = $this->createUid;
        }
        if (null !== $this->phoneNumber) {
            $res['phoneNumber'] = $this->phoneNumber;
        }
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }
        if (null !== $this->showType) {
            $res['showType'] = $this->showType;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountDomain'])) {
            $model->accountDomain = $map['accountDomain'];
        }
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['callInType'])) {
            $model->callInType = $map['callInType'];
        }
        if (isset($map['callOutType'])) {
            $model->callOutType = $map['callOutType'];
        }
        if (isset($map['createUid'])) {
            $model->createUid = $map['createUid'];
        }
        if (isset($map['phoneNumber'])) {
            $model->phoneNumber = $map['phoneNumber'];
        }
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }
        if (isset($map['showType'])) {
            $model->showType = $map['showType'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
