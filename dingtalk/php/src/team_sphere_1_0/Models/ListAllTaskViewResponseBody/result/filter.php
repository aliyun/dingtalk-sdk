<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\filter\conditions;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\filter\invisibleConditions;
use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @var conditions[]
     */
    public $conditions;

    /**
     * @var invisibleConditions[]
     */
    public $invisibleConditions;

    /**
     * @var string
     */
    public $logic;

    /**
     * @var bool
     */
    public $logicDisabled;

    /**
     * @var string
     */
    public $q;
    protected $_name = [
        'conditions'          => 'conditions',
        'invisibleConditions' => 'invisibleConditions',
        'logic'               => 'logic',
        'logicDisabled'       => 'logicDisabled',
        'q'                   => 'q',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conditions) {
            $res['conditions'] = [];
            if (null !== $this->conditions && \is_array($this->conditions)) {
                $n = 0;
                foreach ($this->conditions as $item) {
                    $res['conditions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->invisibleConditions) {
            $res['invisibleConditions'] = [];
            if (null !== $this->invisibleConditions && \is_array($this->invisibleConditions)) {
                $n = 0;
                foreach ($this->invisibleConditions as $item) {
                    $res['invisibleConditions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->logic) {
            $res['logic'] = $this->logic;
        }
        if (null !== $this->logicDisabled) {
            $res['logicDisabled'] = $this->logicDisabled;
        }
        if (null !== $this->q) {
            $res['q'] = $this->q;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filter
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conditions'])) {
            if (!empty($map['conditions'])) {
                $model->conditions = [];
                $n                 = 0;
                foreach ($map['conditions'] as $item) {
                    $model->conditions[$n++] = null !== $item ? conditions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['invisibleConditions'])) {
            if (!empty($map['invisibleConditions'])) {
                $model->invisibleConditions = [];
                $n                          = 0;
                foreach ($map['invisibleConditions'] as $item) {
                    $model->invisibleConditions[$n++] = null !== $item ? invisibleConditions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['logic'])) {
            $model->logic = $map['logic'];
        }
        if (isset($map['logicDisabled'])) {
            $model->logicDisabled = $map['logicDisabled'];
        }
        if (isset($map['q'])) {
            $model->q = $map['q'];
        }

        return $model;
    }
}
