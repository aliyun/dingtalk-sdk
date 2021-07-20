<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\ListItemUserDataResponseBody\studyInfos;
use AlibabaCloud\Tea\Model;

class ListItemUserDataResponseBody extends Model
{
    /**
     * @description 学习的时长记录
     *
     * @var studyInfos[]
     */
    public $studyInfos;
    protected $_name = [
        'studyInfos' => 'studyInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->studyInfos) {
            $res['studyInfos'] = [];
            if (null !== $this->studyInfos && \is_array($this->studyInfos)) {
                $n = 0;
                foreach ($this->studyInfos as $item) {
                    $res['studyInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListItemUserDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['studyInfos'])) {
            if (!empty($map['studyInfos'])) {
                $model->studyInfos = [];
                $n                 = 0;
                foreach ($map['studyInfos'] as $item) {
                    $model->studyInfos[$n++] = null !== $item ? studyInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
