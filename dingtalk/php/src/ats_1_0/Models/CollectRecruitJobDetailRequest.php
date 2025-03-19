<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\recruitUserInfo;
use AlibabaCloud\Tea\Model;

class CollectRecruitJobDetailRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @example zhilian
     *
     * @var string
     */
    public $channel;

    /**
     * @var jobInfo
     */
    public $jobInfo;

    /**
     * @example corpxxxxxxxxx
     *
     * @var string
     */
    public $outCorpId;

    /**
     * @example 小莫科技有限公司
     *
     * @var string
     */
    public $outCorpName;

    /**
     * @var recruitUserInfo
     */
    public $recruitUserInfo;

    /**
     * @example BOSS
     *
     * @var string
     */
    public $source;

    /**
     * @example 1677465956008
     *
     * @var int
     */
    public $updateTime;
    protected $_name = [
        'bizCode' => 'bizCode',
        'channel' => 'channel',
        'jobInfo' => 'jobInfo',
        'outCorpId' => 'outCorpId',
        'outCorpName' => 'outCorpName',
        'recruitUserInfo' => 'recruitUserInfo',
        'source' => 'source',
        'updateTime' => 'updateTime',
    ];

    public function validate() {}

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
