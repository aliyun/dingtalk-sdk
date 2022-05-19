<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteSpaceResponseBody\delFailedDept;
use AlibabaCloud\Tea\Model;

class DeleteSpaceResponseBody extends Model
{
    /**
     * @description 失败列表
     *
     * @var delFailedDept[]
     */
    public $delFailedDept;

    /**
     * @description 删除成功数量
     *
     * @var bool
     */
    public $delSuccessCount;
    protected $_name = [
        'delFailedDept'   => 'delFailedDept',
        'delSuccessCount' => 'delSuccessCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->delFailedDept) {
            $res['delFailedDept'] = [];
            if (null !== $this->delFailedDept && \is_array($this->delFailedDept)) {
                $n = 0;
                foreach ($this->delFailedDept as $item) {
                    $res['delFailedDept'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->delSuccessCount) {
            $res['delSuccessCount'] = $this->delSuccessCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteSpaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['delFailedDept'])) {
            if (!empty($map['delFailedDept'])) {
                $model->delFailedDept = [];
                $n                    = 0;
                foreach ($map['delFailedDept'] as $item) {
                    $model->delFailedDept[$n++] = null !== $item ? delFailedDept::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['delSuccessCount'])) {
            $model->delSuccessCount = $map['delSuccessCount'];
        }

        return $model;
    }
}
