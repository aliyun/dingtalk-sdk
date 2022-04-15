<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks\paragraph\children\text;

use AlibabaCloud\Tea\Model;

class textStyle extends Model
{
    /**
     * @description 是否加粗
     *
     * @var bool
     */
    public $bold;

    /**
     * @description 数据类型
     *
     * @var string
     */
    public $dataType;

    /**
     * @description 字体大小
     *
     * @var int
     */
    public $fontSize;

    /**
     * @description 字体大小单位
     *
     * @var string
     */
    public $sizeUnit;
    protected $_name = [
        'bold'     => 'bold',
        'dataType' => 'dataType',
        'fontSize' => 'fontSize',
        'sizeUnit' => 'sizeUnit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bold) {
            $res['bold'] = $this->bold;
        }
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }
        if (null !== $this->fontSize) {
            $res['fontSize'] = $this->fontSize;
        }
        if (null !== $this->sizeUnit) {
            $res['sizeUnit'] = $this->sizeUnit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return textStyle
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bold'])) {
            $model->bold = $map['bold'];
        }
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }
        if (isset($map['fontSize'])) {
            $model->fontSize = $map['fontSize'];
        }
        if (isset($map['sizeUnit'])) {
            $model->sizeUnit = $map['sizeUnit'];
        }

        return $model;
    }
}
