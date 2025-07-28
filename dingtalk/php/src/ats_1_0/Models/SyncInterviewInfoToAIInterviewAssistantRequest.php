<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\candidateInfoVOList;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\conferenceInfoVO;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\interviewerInfoVOList;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\jobContentVO;
use AlibabaCloud\Tea\Model;

class SyncInterviewInfoToAIInterviewAssistantRequest extends Model
{
    /**
     * @var candidateInfoVOList[]
     */
    public $candidateInfoVOList;

    /**
     * @var conferenceInfoVO
     */
    public $conferenceInfoVO;

    /**
     * @var int
     */
    public $interviewEndTime;

    /**
     * @var string
     */
    public $interviewId;

    /**
     * @var int
     */
    public $interviewStartTime;

    /**
     * @var string
     */
    public $interviewType;

    /**
     * @var interviewerInfoVOList[]
     */
    public $interviewerInfoVOList;

    /**
     * @example moka
     *
     * @var string
     */
    public $isvId;

    /**
     * @var jobContentVO
     */
    public $jobContentVO;
    protected $_name = [
        'candidateInfoVOList' => 'candidateInfoVOList',
        'conferenceInfoVO' => 'conferenceInfoVO',
        'interviewEndTime' => 'interviewEndTime',
        'interviewId' => 'interviewId',
        'interviewStartTime' => 'interviewStartTime',
        'interviewType' => 'interviewType',
        'interviewerInfoVOList' => 'interviewerInfoVOList',
        'isvId' => 'isvId',
        'jobContentVO' => 'jobContentVO',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->candidateInfoVOList) {
            $res['candidateInfoVOList'] = [];
            if (null !== $this->candidateInfoVOList && \is_array($this->candidateInfoVOList)) {
                $n = 0;
                foreach ($this->candidateInfoVOList as $item) {
                    $res['candidateInfoVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->conferenceInfoVO) {
            $res['conferenceInfoVO'] = null !== $this->conferenceInfoVO ? $this->conferenceInfoVO->toMap() : null;
        }
        if (null !== $this->interviewEndTime) {
            $res['interviewEndTime'] = $this->interviewEndTime;
        }
        if (null !== $this->interviewId) {
            $res['interviewId'] = $this->interviewId;
        }
        if (null !== $this->interviewStartTime) {
            $res['interviewStartTime'] = $this->interviewStartTime;
        }
        if (null !== $this->interviewType) {
            $res['interviewType'] = $this->interviewType;
        }
        if (null !== $this->interviewerInfoVOList) {
            $res['interviewerInfoVOList'] = [];
            if (null !== $this->interviewerInfoVOList && \is_array($this->interviewerInfoVOList)) {
                $n = 0;
                foreach ($this->interviewerInfoVOList as $item) {
                    $res['interviewerInfoVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isvId) {
            $res['isvId'] = $this->isvId;
        }
        if (null !== $this->jobContentVO) {
            $res['jobContentVO'] = null !== $this->jobContentVO ? $this->jobContentVO->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncInterviewInfoToAIInterviewAssistantRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['candidateInfoVOList'])) {
            if (!empty($map['candidateInfoVOList'])) {
                $model->candidateInfoVOList = [];
                $n = 0;
                foreach ($map['candidateInfoVOList'] as $item) {
                    $model->candidateInfoVOList[$n++] = null !== $item ? candidateInfoVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['conferenceInfoVO'])) {
            $model->conferenceInfoVO = conferenceInfoVO::fromMap($map['conferenceInfoVO']);
        }
        if (isset($map['interviewEndTime'])) {
            $model->interviewEndTime = $map['interviewEndTime'];
        }
        if (isset($map['interviewId'])) {
            $model->interviewId = $map['interviewId'];
        }
        if (isset($map['interviewStartTime'])) {
            $model->interviewStartTime = $map['interviewStartTime'];
        }
        if (isset($map['interviewType'])) {
            $model->interviewType = $map['interviewType'];
        }
        if (isset($map['interviewerInfoVOList'])) {
            if (!empty($map['interviewerInfoVOList'])) {
                $model->interviewerInfoVOList = [];
                $n = 0;
                foreach ($map['interviewerInfoVOList'] as $item) {
                    $model->interviewerInfoVOList[$n++] = null !== $item ? interviewerInfoVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isvId'])) {
            $model->isvId = $map['isvId'];
        }
        if (isset($map['jobContentVO'])) {
            $model->jobContentVO = jobContentVO::fromMap($map['jobContentVO']);
        }

        return $model;
    }
}
