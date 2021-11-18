<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PollingConfirmStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PollingConfirmStatusResponseBody\universityPollingCourseStatusResponse\livePlayInfoList;
use AlibabaCloud\Tea\Model;

class universityPollingCourseStatusResponse extends Model
{
    /**
     * @description 确认状态
     *
     * @var bool
     */
    public $confirmStatus;

    /**
     * @description 课程编码
     *
     * @var string
     */
    public $courseCode;

    /**
     * @var livePlayInfoList[]
     */
    public $livePlayInfoList;
    protected $_name = [
        'confirmStatus'    => 'confirmStatus',
        'courseCode'       => 'courseCode',
        'livePlayInfoList' => 'livePlayInfoList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->confirmStatus) {
            $res['confirmStatus'] = $this->confirmStatus;
        }
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
        }
        if (null !== $this->livePlayInfoList) {
            $res['livePlayInfoList'] = [];
            if (null !== $this->livePlayInfoList && \is_array($this->livePlayInfoList)) {
                $n = 0;
                foreach ($this->livePlayInfoList as $item) {
                    $res['livePlayInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return universityPollingCourseStatusResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['confirmStatus'])) {
            $model->confirmStatus = $map['confirmStatus'];
        }
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }
        if (isset($map['livePlayInfoList'])) {
            if (!empty($map['livePlayInfoList'])) {
                $model->livePlayInfoList = [];
                $n                       = 0;
                foreach ($map['livePlayInfoList'] as $item) {
                    $model->livePlayInfoList[$n++] = null !== $item ? livePlayInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
