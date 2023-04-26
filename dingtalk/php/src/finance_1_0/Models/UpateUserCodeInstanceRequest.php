<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpateUserCodeInstanceRequest\availableTimes;
use AlibabaCloud\Tea\Model;

class UpateUserCodeInstanceRequest extends Model
{
    /**
     * @var availableTimes[]
     */
    public $availableTimes;

    /**
     * @example ccodexxxxx
     *
     * @var string
     */
    public $codeId;

    /**
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
     * @example corpIdxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @var mixed[]
     */
    public $extInfo;

    /**
     * @var string
     */
    public $gmtExpired;

    /**
     * @example OPEN
     *
     * @var string
     */
    public $status;

    /**
     * @example INTERNAL_STAFF
     *
     * @var string
     */
    public $userCorpRelationType;

    /**
     * @example 86-xxxxxx
     *
     * @var string
     */
    public $userIdentity;
    protected $_name = [
        'availableTimes'       => 'availableTimes',
        'codeId'               => 'codeId',
        'codeIdentity'         => 'codeIdentity',
        'codeValue'            => 'codeValue',
        'corpId'               => 'corpId',
        'extInfo'              => 'extInfo',
        'gmtExpired'           => 'gmtExpired',
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
        if (null !== $this->codeId) {
            $res['codeId'] = $this->codeId;
        }
        if (null !== $this->codeIdentity) {
            $res['codeIdentity'] = $this->codeIdentity;
        }
        if (null !== $this->codeValue) {
            $res['codeValue'] = $this->codeValue;
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
     * @return UpateUserCodeInstanceRequest
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
        if (isset($map['codeId'])) {
            $model->codeId = $map['codeId'];
        }
        if (isset($map['codeIdentity'])) {
            $model->codeIdentity = $map['codeIdentity'];
        }
        if (isset($map['codeValue'])) {
            $model->codeValue = $map['codeValue'];
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
