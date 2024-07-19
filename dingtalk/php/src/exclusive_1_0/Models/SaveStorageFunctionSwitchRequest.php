<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveStorageFunctionSwitchRequest\functionList;
use AlibabaCloud\Tea\Model;

class SaveStorageFunctionSwitchRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 15800000000
     *
     * @var functionList[]
     */
    public $functionList;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxxxx
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'functionList' => 'functionList',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->functionList) {
            $res['functionList'] = [];
            if (null !== $this->functionList && \is_array($this->functionList)) {
                $n = 0;
                foreach ($this->functionList as $item) {
                    $res['functionList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveStorageFunctionSwitchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['functionList'])) {
            if (!empty($map['functionList'])) {
                $model->functionList = [];
                $n                   = 0;
                foreach ($map['functionList'] as $item) {
                    $model->functionList[$n++] = null !== $item ? functionList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
