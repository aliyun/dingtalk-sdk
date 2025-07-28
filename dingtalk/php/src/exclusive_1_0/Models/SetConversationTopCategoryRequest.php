<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationTopCategoryRequest\setCategoryList;
use AlibabaCloud\Tea\Model;

class SetConversationTopCategoryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cidxxxx
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var setCategoryList[]
     */
    public $setCategoryList;

    /**
     * @example 10
     *
     * @var int
     */
    public $sign;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'setCategoryList' => 'setCategoryList',
        'sign' => 'sign',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->setCategoryList) {
            $res['setCategoryList'] = [];
            if (null !== $this->setCategoryList && \is_array($this->setCategoryList)) {
                $n = 0;
                foreach ($this->setCategoryList as $item) {
                    $res['setCategoryList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sign) {
            $res['sign'] = $this->sign;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetConversationTopCategoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['setCategoryList'])) {
            if (!empty($map['setCategoryList'])) {
                $model->setCategoryList = [];
                $n = 0;
                foreach ($map['setCategoryList'] as $item) {
                    $model->setCategoryList[$n++] = null !== $item ? setCategoryList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sign'])) {
            $model->sign = $map['sign'];
        }

        return $model;
    }
}
