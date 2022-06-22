<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result\substituteSubmitConf\submitterList;
use AlibabaCloud\Tea\Model;

class substituteSubmitConf extends Model
{
    /**
     * @description 是否允许代提交
     *
     * @var bool
     */
    public $enable;

    /**
     * @description 代提交人
     *
     * @var submitterList[]
     */
    public $submitterList;
    protected $_name = [
        'enable'        => 'enable',
        'submitterList' => 'submitterList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->enable) {
            $res['enable'] = $this->enable;
        }
        if (null !== $this->submitterList) {
            $res['submitterList'] = [];
            if (null !== $this->submitterList && \is_array($this->submitterList)) {
                $n = 0;
                foreach ($this->submitterList as $item) {
                    $res['submitterList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return substituteSubmitConf
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enable'])) {
            $model->enable = $map['enable'];
        }
        if (isset($map['submitterList'])) {
            if (!empty($map['submitterList'])) {
                $model->submitterList = [];
                $n                    = 0;
                foreach ($map['submitterList'] as $item) {
                    $model->submitterList[$n++] = null !== $item ? submitterList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
