<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListUserVisibleBpmsProcessesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListUserVisibleBpmsProcessesResponseBody\result\processList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 下一次分页调用的值，当返回结果里没有nextToken时，表示分页结束。
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 可见表单列表。
     *
     * @var processList[]
     */
    public $processList;
    protected $_name = [
        'nextToken'   => 'nextToken',
        'processList' => 'processList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->processList) {
            $res['processList'] = [];
            if (null !== $this->processList && \is_array($this->processList)) {
                $n = 0;
                foreach ($this->processList as $item) {
                    $res['processList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['processList'])) {
            if (!empty($map['processList'])) {
                $model->processList = [];
                $n                  = 0;
                foreach ($map['processList'] as $item) {
                    $model->processList[$n++] = null !== $item ? processList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
