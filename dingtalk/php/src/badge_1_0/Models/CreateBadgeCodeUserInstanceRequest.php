<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\CreateBadgeCodeUserInstanceRequest\availableTimes;
use AlibabaCloud\Tea\Model;

class CreateBadgeCodeUserInstanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var availableTimes[]
     */
    public $availableTimes;

    /**
     * @description This parameter is required.
     *
     * @example TEST
     *
     * @var string
     */
    public $codeIdentity;

    /**
     * @var string
     */
    public $codeValue;

    /**
     * @example DING_STATIC
     *
     * @var string
     */
    public $codeValueType;

    /**
     * @description This parameter is required.
     *
     * @example corpid1234
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var mixed[]
     */
    public $extInfo;

    /**
     * @description This parameter is required.
     *
     * @example yyyy-MM-dd HH:mm:ss
     *
     * @var string
     */
    public $gmtExpired;

    /**
     * @description This parameter is required.
     *
     * @example 202102021212
     *
     * @var string
     */
    public $requestId;

    /**
     * @description This parameter is required.
     *
     * @example OPEN
     *
     * @var string
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example INTERNAL_STAFF
     *
     * @var string
     */
    public $userCorpRelationType;

    /**
     * @description This parameter is required.
     *
     * @example 86-xxxxxx
     *
     * @var string
     */
    public $userIdentity;
    protected $_name = [
        'availableTimes'       => 'availableTimes',
        'codeIdentity'         => 'codeIdentity',
        'codeValue'            => 'codeValue',
        'codeValueType'        => 'codeValueType',
        'corpId'               => 'corpId',
        'extInfo'              => 'extInfo',
        'gmtExpired'           => 'gmtExpired',
        'requestId'            => 'requestId',
        'status'               => 'status',
        'userCorpRelationType' => 'userCorpRelationType',
        'userIdentity'         => 'userIdentity',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->availableTimes) {
            $res['availableTimes'] = [];
            if (null !== $this->availableTimes && \is_array($this->availableTimes)) {
                $n = 0;
                foreach ($this->availableTimes as $item) {
                    $res['availableTimes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->codeIdentity) {
            $res['codeIdentity'] = $this->codeIdentity;
        }
        if (null !== $this->codeValue) {
            $res['codeValue'] = $this->codeValue;
        }
        if (null !== $this->codeValueType) {
            $res['codeValueType'] = $this->codeValueType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->gmtExpired) {
            $res['gmtExpired'] = $this->gmtExpired;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userCorpRelationType) {
            $res['userCorpRelationType'] = $this->userCorpRelationType;
        }
        if (null !== $this->userIdentity) {
            $res['userIdentity'] = $this->userIdentity;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateBadgeCodeUserInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['availableTimes'])) {
            if (!empty($map['availableTimes'])) {
                $model->availableTimes = [];
                $n                     = 0;
                foreach ($map['availableTimes'] as $item) {
                    $model->availableTimes[$n++] = null !== $item ? availableTimes::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['codeIdentity'])) {
            $model->codeIdentity = $map['codeIdentity'];
        }
        if (isset($map['codeValue'])) {
            $model->codeValue = $map['codeValue'];
        }
        if (isset($map['codeValueType'])) {
            $model->codeValueType = $map['codeValueType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['gmtExpired'])) {
            $model->gmtExpired = $map['gmtExpired'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userCorpRelationType'])) {
            $model->userCorpRelationType = $map['userCorpRelationType'];
        }
        if (isset($map['userIdentity'])) {
            $model->userIdentity = $map['userIdentity'];
        }

        return $model;
    }
}
