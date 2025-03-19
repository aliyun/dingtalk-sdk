<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeFile;
use AlibabaCloud\Tea\Model;

class CollectResumeDetailRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @example liepin
     *
     * @var string
     */
    public $channelCode;

    /**
     * @example resumexxxxxxxxxx
     *
     * @var string
     */
    public $channelOuterId;

    /**
     * @example xxxxxx
     *
     * @var string
     */
    public $channelTalentId;

    /**
     * @description This parameter is required.
     *
     * @example jobId8fc0d56a605d495ea0214af7axxxxxxx
     *
     * @var string
     */
    public $deliverJobId;

    /**
     * @description This parameter is required.
     *
     * @example 2701606624233xxxxx
     *
     * @var string
     */
    public $optUserId;

    /**
     * @example http:www.xxx.com
     *
     * @var string
     */
    public $resumeChannelUrl;

    /**
     * @description This parameter is required.
     *
     * @var resumeData
     */
    public $resumeData;

    /**
     * @var resumeFile
     */
    public $resumeFile;
    protected $_name = [
        'bizCode' => 'bizCode',
        'channelCode' => 'channelCode',
        'channelOuterId' => 'channelOuterId',
        'channelTalentId' => 'channelTalentId',
        'deliverJobId' => 'deliverJobId',
        'optUserId' => 'optUserId',
        'resumeChannelUrl' => 'resumeChannelUrl',
        'resumeData' => 'resumeData',
        'resumeFile' => 'resumeFile',
    ];

    public function validate() {}

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
