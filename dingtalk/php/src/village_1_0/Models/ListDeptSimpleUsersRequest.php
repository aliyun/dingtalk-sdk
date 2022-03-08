<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListDeptSimpleUsersRequest extends Model
{
    /**
     * @description containAccessLimit
     *
     * @var bool
     */
    public $containAccessLimit;

    /**
     * @description cursor
     *
     * @var int
     */
    public $cursor;

    /**
     * @description language
     *
     * @var string
     */
    public $language;

    /**
     * @description orderField
     *
     * @var string
     */
    public $orderField;

    /**
     * @description size
     *
     * @var int
     */
    public $size;

    /**
     * @description 下属组织的组织ID，比如下属镇、村的corpId
     *
     * @var string
     */
    public $subCorpId;
    protected $_name = [
        'containAccessLimit' => 'containAccessLimit',
        'cursor'             => 'cursor',
        'language'           => 'language',
        'orderField'         => 'orderField',
        'size'               => 'size',
        'subCorpId'          => 'subCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->containAccessLimit) {
            $res['containAccessLimit'] = $this->containAccessLimit;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->orderField) {
            $res['orderField'] = $this->orderField;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListDeptSimpleUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['containAccessLimit'])) {
            $model->containAccessLimit = $map['containAccessLimit'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['orderField'])) {
            $model->orderField = $map['orderField'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }

        return $model;
    }
}
