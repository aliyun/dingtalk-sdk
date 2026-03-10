<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListTeamResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListTeamResponseBody\result\tagList\valueList;
use AlibabaCloud\Tea\Model;

class tagList extends Model
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
     * @var valueList[]
     */
    public $valueList;
    protected $_name = [
        'code' => 'code',
        'name' => 'name',
        'valueList' => 'valueList',
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
        if (null !== $this->valueList) {
            $res['valueList'] = [];
            if (null !== $this->valueList && \is_array($this->valueList)) {
                $n = 0;
                foreach ($this->valueList as $item) {
                    $res['valueList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tagList
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
        if (isset($map['valueList'])) {
            if (!empty($map['valueList'])) {
                $model->valueList = [];
                $n = 0;
                foreach ($map['valueList'] as $item) {
                    $model->valueList[$n++] = null !== $item ? valueList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
