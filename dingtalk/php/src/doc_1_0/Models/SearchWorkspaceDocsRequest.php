<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchWorkspaceDocsRequest extends Model
{
    /**
     * @description 发起操作用户unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 搜索关键字
     *
     * @var string
     */
    public $keyword;

    /**
     * @description 搜索数量
     *
     * @var int
     */
    public $size;

    /**
     * @description 翻页Id
     *
     * @var string
     */
    public $loadMoreId;
    protected $_name = [
        'operatorId' => 'operatorId',
        'keyword'    => 'keyword',
        'size'       => 'size',
        'loadMoreId' => 'loadMoreId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->keyword) {
            $res['keyword'] = $this->keyword;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->loadMoreId) {
            $res['loadMoreId'] = $this->loadMoreId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchWorkspaceDocsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['keyword'])) {
            $model->keyword = $map['keyword'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['loadMoreId'])) {
            $model->loadMoreId = $map['loadMoreId'];
        }

        return $model;
    }
}
