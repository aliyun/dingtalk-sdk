<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InsertSectionConfigRequest\end;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InsertSectionConfigRequest\sectionModels;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InsertSectionConfigRequest\start;
use AlibabaCloud\Tea\Model;

class InsertSectionConfigRequest extends Model
{
    /**
     * @description 结束日期
     *
     * @var end
     */
    public $end;

    /**
     * @description 课程表名称
     *
     * @var string
     */
    public $scheduleName;

    /**
     * @description 节次模型
     *
     * @var sectionModels[]
     */
    public $sectionModels;

    /**
     * @description 开始日期
     *
     * @var start
     */
    public $start;

    /**
     * @description 操作人的userid。
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'end'           => 'end',
        'scheduleName'  => 'scheduleName',
        'sectionModels' => 'sectionModels',
        'start'         => 'start',
        'opUserId'      => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->end) {
            $res['end'] = null !== $this->end ? $this->end->toMap() : null;
        }
        if (null !== $this->scheduleName) {
            $res['scheduleName'] = $this->scheduleName;
        }
        if (null !== $this->sectionModels) {
            $res['sectionModels'] = [];
            if (null !== $this->sectionModels && \is_array($this->sectionModels)) {
                $n = 0;
                foreach ($this->sectionModels as $item) {
                    $res['sectionModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->start) {
            $res['start'] = null !== $this->start ? $this->start->toMap() : null;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InsertSectionConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['end'])) {
            $model->end = end::fromMap($map['end']);
        }
        if (isset($map['scheduleName'])) {
            $model->scheduleName = $map['scheduleName'];
        }
        if (isset($map['sectionModels'])) {
            if (!empty($map['sectionModels'])) {
                $model->sectionModels = [];
                $n                    = 0;
                foreach ($map['sectionModels'] as $item) {
                    $model->sectionModels[$n++] = null !== $item ? sectionModels::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['start'])) {
            $model->start = start::fromMap($map['start']);
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
