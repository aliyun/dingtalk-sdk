<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelatedViewTabDataResponseBody\relatedViewTabDataResponse\relatedViewTabPageData;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example 西游四人组:孙悟空
     *
     * @var string
     */
    public $abstractMessage;

    /**
     * @example 1722059884000
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 王凯提交的楚衣的流程表单2
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'abstractMessage' => 'abstractMessage',
        'createTime'      => 'createTime',
        'title'           => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->abstractMessage) {
            $res['abstractMessage'] = $this->abstractMessage;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['abstractMessage'])) {
            $model->abstractMessage = $map['abstractMessage'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
