<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SheetFindAllRequest\findOptions;
use AlibabaCloud\Tea\Model;

class SheetFindAllRequest extends Model
{
    /**
     * @description 查找选项
     *
     * @var findOptions
     */
    public $findOptions;

    /**
     * @description 要查找的文本
     *
     * @var string
     */
    public $text;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @var string
     */
    public $select;
    protected $_name = [
        'findOptions' => 'findOptions',
        'text'        => 'text',
        'operatorId'  => 'operatorId',
        'select'      => 'select',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->findOptions) {
            $res['findOptions'] = null !== $this->findOptions ? $this->findOptions->toMap() : null;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->select) {
            $res['select'] = $this->select;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SheetFindAllRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['findOptions'])) {
            $model->findOptions = findOptions::fromMap($map['findOptions']);
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['select'])) {
            $model->select = $map['select'];
        }

        return $model;
    }
}
