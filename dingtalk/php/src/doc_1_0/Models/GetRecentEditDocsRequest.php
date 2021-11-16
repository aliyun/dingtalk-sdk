<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRecentEditDocsRequest extends Model
{
    /**
     * @description 发起操作用户unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 查询size
     *
     * @var int
     */
    public $size;

    /**
     * @var string
     */
    public $loadMoreId;
    protected $_name = [
        'operatorId' => 'operatorId',
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
     * @return GetRecentEditDocsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
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
