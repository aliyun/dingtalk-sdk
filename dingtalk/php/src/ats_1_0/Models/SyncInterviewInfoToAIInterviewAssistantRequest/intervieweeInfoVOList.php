<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\intervieweeInfoVOList\historyInterviewInfoVOList;
use AlibabaCloud\Tea\Model;

class intervieweeInfoVOList extends Model
{
    /**
     * @var string
     */
    public $bizIntervieweeId;

    /**
     * @var historyInterviewInfoVOList[]
     */
    public $historyInterviewInfoVOList;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $phone;

    /**
     * @var string
     */
    public $resumeContent;
    protected $_name = [
        'bizIntervieweeId' => 'bizIntervieweeId',
        'historyInterviewInfoVOList' => 'historyInterviewInfoVOList',
        'name' => 'name',
        'phone' => 'phone',
        'resumeContent' => 'resumeContent',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizIntervieweeId) {
            $res['bizIntervieweeId'] = $this->bizIntervieweeId;
        }
        if (null !== $this->historyInterviewInfoVOList) {
            $res['historyInterviewInfoVOList'] = [];
            if (null !== $this->historyInterviewInfoVOList && \is_array($this->historyInterviewInfoVOList)) {
                $n = 0;
                foreach ($this->historyInterviewInfoVOList as $item) {
                    $res['historyInterviewInfoVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->phone) {
            $res['phone'] = $this->phone;
        }
        if (null !== $this->resumeContent) {
            $res['resumeContent'] = $this->resumeContent;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return intervieweeInfoVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizIntervieweeId'])) {
            $model->bizIntervieweeId = $map['bizIntervieweeId'];
        }
        if (isset($map['historyInterviewInfoVOList'])) {
            if (!empty($map['historyInterviewInfoVOList'])) {
                $model->historyInterviewInfoVOList = [];
                $n = 0;
                foreach ($map['historyInterviewInfoVOList'] as $item) {
                    $model->historyInterviewInfoVOList[$n++] = null !== $item ? historyInterviewInfoVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['phone'])) {
            $model->phone = $map['phone'];
        }
        if (isset($map['resumeContent'])) {
            $model->resumeContent = $map['resumeContent'];
        }

        return $model;
    }
}
