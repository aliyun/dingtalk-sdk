<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetSolutionConfigResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetSolutionConfigResponseBody\result\solutionList\sceneList;
use AlibabaCloud\Tea\Model;

class solutionList extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $name;

    /**
     * @var sceneList[]
     */
    public $sceneList;
    protected $_name = [
        'code' => 'code',
        'name' => 'name',
        'sceneList' => 'sceneList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sceneList) {
            $res['sceneList'] = [];
            if (null !== $this->sceneList && \is_array($this->sceneList)) {
                $n = 0;
                foreach ($this->sceneList as $item) {
                    $res['sceneList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return solutionList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sceneList'])) {
            if (!empty($map['sceneList'])) {
                $model->sceneList = [];
                $n = 0;
                foreach ($map['sceneList'] as $item) {
                    $model->sceneList[$n++] = null !== $item ? sceneList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
