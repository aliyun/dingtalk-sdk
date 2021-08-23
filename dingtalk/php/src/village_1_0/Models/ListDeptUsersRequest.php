<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListDeptUsersRequest extends Model
{
    /**
     * @description cursor
     *
     * @var int
     */
    public $cursor;

    /**
     * @description size
     *
     * @var int
     */
    public $size;

    /**
     * @description containAccessLimit
     *
     * @var bool
     */
    public $containAccessLimit;

    /**
     * @description subCorpId
     *
     * @var string
     */
    public $subCorpId;

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
    protected $_name = [
        'cursor'             => 'cursor',
        'size'               => 'size',
        'containAccessLimit' => 'containAccessLimit',
        'subCorpId'          => 'subCorpId',
        'language'           => 'language',
        'orderField'         => 'orderField',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->containAccessLimit) {
            $res['containAccessLimit'] = $this->containAccessLimit;
        }
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->orderField) {
            $res['orderField'] = $this->orderField;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListDeptUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['containAccessLimit'])) {
            $model->containAccessLimit = $map['containAccessLimit'];
        }
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['orderField'])) {
            $model->orderField = $map['orderField'];
        }

        return $model;
    }
}
