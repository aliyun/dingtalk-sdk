<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressResponseBody\result\classStatistics;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressResponseBody\result\patriarchStatistics;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var classStatistics[]
     */
    public $classStatistics;

    /**
     * @var patriarchStatistics[]
     */
    public $patriarchStatistics;

    /**
     * @var string[]
     */
    public $studentNameList;
    protected $_name = [
        'classStatistics' => 'classStatistics',
        'patriarchStatistics' => 'patriarchStatistics',
        'studentNameList' => 'studentNameList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classStatistics) {
            $res['classStatistics'] = [];
            if (null !== $this->classStatistics && \is_array($this->classStatistics)) {
                $n = 0;
                foreach ($this->classStatistics as $item) {
                    $res['classStatistics'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->patriarchStatistics) {
            $res['patriarchStatistics'] = [];
            if (null !== $this->patriarchStatistics && \is_array($this->patriarchStatistics)) {
                $n = 0;
                foreach ($this->patriarchStatistics as $item) {
                    $res['patriarchStatistics'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->studentNameList) {
            $res['studentNameList'] = $this->studentNameList;
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
        if (isset($map['classStatistics'])) {
            if (!empty($map['classStatistics'])) {
                $model->classStatistics = [];
                $n = 0;
                foreach ($map['classStatistics'] as $item) {
                    $model->classStatistics[$n++] = null !== $item ? classStatistics::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['patriarchStatistics'])) {
            if (!empty($map['patriarchStatistics'])) {
                $model->patriarchStatistics = [];
                $n = 0;
                foreach ($map['patriarchStatistics'] as $item) {
                    $model->patriarchStatistics[$n++] = null !== $item ? patriarchStatistics::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['studentNameList'])) {
            if (!empty($map['studentNameList'])) {
                $model->studentNameList = $map['studentNameList'];
            }
        }

        return $model;
    }
}
