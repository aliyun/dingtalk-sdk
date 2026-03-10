<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\ConvertUnionIdResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\ConvertUnionIdResponseBody\result\isvUserUnionIdVOList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example corpId123
     *
     * @var string
     */
    public $corpId;

    /**
     * @var isvUserUnionIdVOList[]
     */
    public $isvUserUnionIdVOList;
    protected $_name = [
        'corpId' => 'corpId',
        'isvUserUnionIdVOList' => 'isvUserUnionIdVOList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvUserUnionIdVOList) {
            $res['isvUserUnionIdVOList'] = [];
            if (null !== $this->isvUserUnionIdVOList && \is_array($this->isvUserUnionIdVOList)) {
                $n = 0;
                foreach ($this->isvUserUnionIdVOList as $item) {
                    $res['isvUserUnionIdVOList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['isvUserUnionIdVOList'])) {
            if (!empty($map['isvUserUnionIdVOList'])) {
                $model->isvUserUnionIdVOList = [];
                $n = 0;
                foreach ($map['isvUserUnionIdVOList'] as $item) {
                    $model->isvUserUnionIdVOList[$n++] = null !== $item ? isvUserUnionIdVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
