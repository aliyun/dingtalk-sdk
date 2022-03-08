<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\CreateBadgeCodeUserInstanceRequest\availableTimes;
use AlibabaCloud\Tea\Model;

class CreateBadgeCodeUserInstanceRequest extends Model
{
    /**
     * @description 有效时间列表，对于连续时间段，只需传入一个对象即可，注意过期时间必须晚于最晚结束时间
     *
     * @var availableTimes[]
     */
    public $availableTimes;

    /**
     * @description 码标识，由钉钉颁发
     *
     * @var string
     */
    public $codeIdentity;

    /**
     * @description 码值
     *
     * @var string
     */
    public $codeValue;

    /**
     * @description 码值类型，钉钉静态码值：DING_STATIC，访客码或会展码传入
     *
     * @var string
     */
    public $codeValueType;

    /**
     * @description 企业ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 扩展参数
     *
     * @var mixed[]
     */
    public $extInfo;

    /**
     * @description 临时码，传入过期时间
     *
     * @var string
     */
    public $gmtExpired;

    /**
     * @description 业务幂等ID
     *
     * @var string
     */
    public $requestId;

    /**
     * @description 状态，传入关闭状态需要用户手动开启后才会渲染二维
     *
     * @var string
     */
    public $status;

    /**
     * @description 用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户
     *
     * @var string
     */
    public $userCorpRelationType;

    /**
     * @description 用户身份标识，取值和用户企业关系类型相关，如果企业无关，传入手机号
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
