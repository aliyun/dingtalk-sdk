<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoUpdateTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoUpdateTaskResponseBody\data\groupVoList;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var groupVoList[]
     */
    public $groupVoList;

    /**
     * @var string
     */
    public $taskId;
    protected $_name = [
        'groupVoList' => 'groupVoList',
        'taskId' => 'taskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupVoList) {
            $res['groupVoList'] = [];
            if (null !== $this->groupVoList && \is_array($this->groupVoList)) {
                $n = 0;
                foreach ($this->groupVoList as $item) {
                    $res['groupVoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupVoList'])) {
            if (!empty($map['groupVoList'])) {
                $model->groupVoList = [];
                $n = 0;
                foreach ($map['groupVoList'] as $item) {
                    $model->groupVoList[$n++] = null !== $item ? groupVoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
