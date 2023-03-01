<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\recruitUserInfo;
use AlibabaCloud\Tea\Model;

class CollectRecruitJobDetailRequest extends Model
{
    /**
     * @description 业务标识，目前固定为ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 渠道ID
     *
     * @var string
     */
    public $channel;

    /**
     * @var jobInfo
     */
    public $jobInfo;

    /**
     * @description 渠道侧外部企业唯一ID
     *
     * @var string
     */
    public $outCorpId;

    /**
     * @description 企业名称
     *
     * @var string
     */
    public $outCorpName;

    /**
     * @description 招聘人信息
     *
     * @var recruitUserInfo
     */
    public $recruitUserInfo;

    /**
     * @description 来源
     *
     * @var string
     */
    public $source;

    /**
     * @description 数据源更新时间
     *
     * @var int
     */
    public $updateTime;
    protected $_name = [
        'bizCode'         => 'bizCode',
        'channel'         => 'channel',
        'jobInfo'         => 'jobInfo',
        'outCorpId'       => 'outCorpId',
        'outCorpName'     => 'outCorpName',
        'recruitUserInfo' => 'recruitUserInfo',
        'source'          => 'source',
        'updateTime'      => 'updateTime',
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
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->jobInfo) {
            $res['jobInfo'] = null !== $this->jobInfo ? $this->jobInfo->toMap() : null;
        }
        if (null !== $this->outCorpId) {
            $res['outCorpId'] = $this->outCorpId;
        }
        if (null !== $this->outCorpName) {
            $res['outCorpName'] = $this->outCorpName;
        }
        if (null !== $this->recruitUserInfo) {
            $res['recruitUserInfo'] = null !== $this->recruitUserInfo ? $this->recruitUserInfo->toMap() : null;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollectRecruitJobDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['jobInfo'])) {
            $model->jobInfo = jobInfo::fromMap($map['jobInfo']);
        }
        if (isset($map['outCorpId'])) {
            $model->outCorpId = $map['outCorpId'];
        }
        if (isset($map['outCorpName'])) {
            $model->outCorpName = $map['outCorpName'];
        }
        if (isset($map['recruitUserInfo'])) {
            $model->recruitUserInfo = recruitUserInfo::fromMap($map['recruitUserInfo']);
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }

        return $model;
    }
}
