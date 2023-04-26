<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataRemovalTableDataResponseBody\data\modifyUser;

use AlibabaCloud\Tea\Model;

class name extends Model
{
    /**
     * @example 张三
     *
     * @var string
     */
    public $nameInChinese;

    /**
     * @example ZhangSan
     *
     * @var string
     */
    public $nameInEnglish;
    protected $_name = [
        'nameInChinese' => 'nameInChinese',
        'nameInEnglish' => 'nameInEnglish',
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

        return $model;
    }
}
