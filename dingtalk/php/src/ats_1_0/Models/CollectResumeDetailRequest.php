<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;
use AlibabaCloud\Tea\Model;

class CollectResumeDetailRequest extends Model
{
    /**
     * @description 业务标识，目前固定为ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 渠道侧简历标识
     *
     * @var string
     */
    public $channelOuterId;

    /**
     * @description 渠道侧候选人标识。
     *
     * @var string
     */
    public $channelTalentId;

    /**
     * @description 简历投递职位标识
     *
     * @var string
     */
    public $deliverJobId;

    /**
     * @var string
     */
    public $optUserId;

    /**
     * @description 简历详情信息
     *
     * @var resumeData
     */
    public $resumeData;
    protected $_name = [
        'bizCode'         => 'bizCode',
        'channelOuterId'  => 'channelOuterId',
        'channelTalentId' => 'channelTalentId',
        'deliverJobId'    => 'deliverJobId',
        'optUserId'       => 'optUserId',
        'resumeData'      => 'resumeData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->channelOuterId) {
            $res['channelOuterId'] = $this->channelOuterId;
        }
        if (null !== $this->channelTalentId) {
            $res['channelTalentId'] = $this->channelTalentId;
        }
        if (null !== $this->deliverJobId) {
            $res['deliverJobId'] = $this->deliverJobId;
        }
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }
        if (null !== $this->resumeData) {
            $res['resumeData'] = null !== $this->resumeData ? $this->resumeData->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollectResumeDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['channelOuterId'])) {
            $model->channelOuterId = $map['channelOuterId'];
        }
        if (isset($map['channelTalentId'])) {
            $model->channelTalentId = $map['channelTalentId'];
        }
        if (isset($map['deliverJobId'])) {
            $model->deliverJobId = $map['deliverJobId'];
        }
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }
        if (isset($map['resumeData'])) {
            $model->resumeData = resumeData::fromMap($map['resumeData']);
        }

        return $model;
    }
}
