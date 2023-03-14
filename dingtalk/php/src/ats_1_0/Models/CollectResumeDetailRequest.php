<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeFile;
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
     * @description 渠道编码
     *
     * @var string
     */
    public $channelCode;

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
     * @description 渠道简历链接
     *
     * @var string
     */
    public $resumeChannelUrl;

    /**
     * @description 简历详情信息
     *
     * @var resumeData
     */
    public $resumeData;

    /**
     * @description 原始简历文件
     *
     * @var resumeFile
     */
    public $resumeFile;
    protected $_name = [
        'bizCode'          => 'bizCode',
        'channelCode'      => 'channelCode',
        'channelOuterId'   => 'channelOuterId',
        'channelTalentId'  => 'channelTalentId',
        'deliverJobId'     => 'deliverJobId',
        'optUserId'        => 'optUserId',
        'resumeChannelUrl' => 'resumeChannelUrl',
        'resumeData'       => 'resumeData',
        'resumeFile'       => 'resumeFile',
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
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
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
        if (null !== $this->resumeChannelUrl) {
            $res['resumeChannelUrl'] = $this->resumeChannelUrl;
        }
        if (null !== $this->resumeData) {
            $res['resumeData'] = null !== $this->resumeData ? $this->resumeData->toMap() : null;
        }
        if (null !== $this->resumeFile) {
            $res['resumeFile'] = null !== $this->resumeFile ? $this->resumeFile->toMap() : null;
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
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
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
        if (isset($map['resumeChannelUrl'])) {
            $model->resumeChannelUrl = $map['resumeChannelUrl'];
        }
        if (isset($map['resumeData'])) {
            $model->resumeData = resumeData::fromMap($map['resumeData']);
        }
        if (isset($map['resumeFile'])) {
            $model->resumeFile = resumeFile::fromMap($map['resumeFile']);
        }

        return $model;
    }
}
