<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesResponseBody\data\actionExecutor;

use AlibabaCloud\Tea\Model;

class name extends Model
{
    /**
     * @description 中文名称
     *
     * @var string
     */
    public $nameInChinese;

    /**
     * @description 英文名称
     *
     * @var string
     */
    public $nameInEnglish;

    /**
     * @description type
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'nameInChinese' => 'nameInChinese',
        'nameInEnglish' => 'nameInEnglish',
        'type'          => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nameInChinese) {
            $res['nameInChinese'] = $this->nameInChinese;
        }
        if (null !== $this->nameInEnglish) {
            $res['nameInEnglish'] = $this->nameInEnglish;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return name
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nameInChinese'])) {
            $model->nameInChinese = $map['nameInChinese'];
        }
        if (isset($map['nameInEnglish'])) {
            $model->nameInEnglish = $map['nameInEnglish'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
