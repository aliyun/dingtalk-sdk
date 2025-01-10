<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetAllDismissionReasonsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetAllDismissionReasonsResponseBody\result\passiveList;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetAllDismissionReasonsResponseBody\result\voluntaryList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var passiveList[]
     */
    public $passiveList;

    /**
     * @var voluntaryList[]
     */
    public $voluntaryList;
    protected $_name = [
        'passiveList'   => 'passiveList',
        'voluntaryList' => 'voluntaryList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->passiveList) {
            $res['passiveList'] = [];
            if (null !== $this->passiveList && \is_array($this->passiveList)) {
                $n = 0;
                foreach ($this->passiveList as $item) {
                    $res['passiveList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->voluntaryList) {
            $res['voluntaryList'] = [];
            if (null !== $this->voluntaryList && \is_array($this->voluntaryList)) {
                $n = 0;
                foreach ($this->voluntaryList as $item) {
                    $res['voluntaryList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['passiveList'])) {
            if (!empty($map['passiveList'])) {
                $model->passiveList = [];
                $n                  = 0;
                foreach ($map['passiveList'] as $item) {
                    $model->passiveList[$n++] = null !== $item ? passiveList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['voluntaryList'])) {
            if (!empty($map['voluntaryList'])) {
                $model->voluntaryList = [];
                $n                    = 0;
                foreach ($map['voluntaryList'] as $item) {
                    $model->voluntaryList[$n++] = null !== $item ? voluntaryList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
