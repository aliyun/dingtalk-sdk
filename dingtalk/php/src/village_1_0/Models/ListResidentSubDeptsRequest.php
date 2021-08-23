<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListResidentSubDeptsRequest extends Model
{
    /**
     * @description 真实请求的组织corpId
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description 游标，不传默认1
     *
     * @var int
     */
    public $cursor;

    /**
     * @description 大小
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'subCorpId' => 'subCorpId',
        'cursor'    => 'cursor',
        'size'      => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListResidentSubDeptsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
