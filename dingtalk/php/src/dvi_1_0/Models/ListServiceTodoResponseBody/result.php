<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListServiceTodoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListServiceTodoResponseBody\result\executors;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $creator;

    /**
     * @var string
     */
    public $dingTodoId;

    /**
     * @var executors[]
     */
    public $executors;

    /**
     * @var bool
     */
    public $finished;

    /**
     * @var int
     */
    public $planFinishDate;

    /**
     * @var string
     */
    public $todoContent;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'creator' => 'creator',
        'dingTodoId' => 'dingTodoId',
        'executors' => 'executors',
        'finished' => 'finished',
        'planFinishDate' => 'planFinishDate',
        'todoContent' => 'todoContent',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->dingTodoId) {
            $res['dingTodoId'] = $this->dingTodoId;
        }
        if (null !== $this->executors) {
            $res['executors'] = [];
            if (null !== $this->executors && \is_array($this->executors)) {
                $n = 0;
                foreach ($this->executors as $item) {
                    $res['executors'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->finished) {
            $res['finished'] = $this->finished;
        }
        if (null !== $this->planFinishDate) {
            $res['planFinishDate'] = $this->planFinishDate;
        }
        if (null !== $this->todoContent) {
            $res['todoContent'] = $this->todoContent;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['dingTodoId'])) {
            $model->dingTodoId = $map['dingTodoId'];
        }
        if (isset($map['executors'])) {
            if (!empty($map['executors'])) {
                $model->executors = [];
                $n = 0;
                foreach ($map['executors'] as $item) {
                    $model->executors[$n++] = null !== $item ? executors::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['finished'])) {
            $model->finished = $map['finished'];
        }
        if (isset($map['planFinishDate'])) {
            $model->planFinishDate = $map['planFinishDate'];
        }
        if (isset($map['todoContent'])) {
            $model->todoContent = $map['todoContent'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
