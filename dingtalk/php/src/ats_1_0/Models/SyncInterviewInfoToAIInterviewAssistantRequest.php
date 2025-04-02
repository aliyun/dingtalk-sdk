<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\conferenceInfoVO;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\intervieweeInfoVOList;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\interviewerInfoVOList;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\jobContentVO;
use AlibabaCloud\Tea\Model;

class SyncInterviewInfoToAIInterviewAssistantRequest extends Model
{
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
     * @var intervieweeInfoVOList[]
     */
    public $intervieweeInfoVOList;

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
        'conferenceInfoVO' => 'conferenceInfoVO',
        'interviewEndTime' => 'interviewEndTime',
        'interviewId' => 'interviewId',
        'interviewStartTime' => 'interviewStartTime',
        'interviewType' => 'interviewType',
        'intervieweeInfoVOList' => 'intervieweeInfoVOList',
        'interviewerInfoVOList' => 'interviewerInfoVOList',
        'isvId' => 'isvId',
        'jobContentVO' => 'jobContentVO',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->intervieweeInfoVOList) {
            $res['intervieweeInfoVOList'] = [];
            if (null !== $this->intervieweeInfoVOList && \is_array($this->intervieweeInfoVOList)) {
                $n = 0;
                foreach ($this->intervieweeInfoVOList as $item) {
                    $res['intervieweeInfoVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['intervieweeInfoVOList'])) {
            if (!empty($map['intervieweeInfoVOList'])) {
                $model->intervieweeInfoVOList = [];
                $n = 0;
                foreach ($map['intervieweeInfoVOList'] as $item) {
                    $model->intervieweeInfoVOList[$n++] = null !== $item ? intervieweeInfoVOList::fromMap($item) : $item;
                }
            }
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
