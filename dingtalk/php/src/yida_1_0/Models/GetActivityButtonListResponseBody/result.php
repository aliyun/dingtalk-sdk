<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityButtonListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description alias
     *
     * @var string
     */
    public $aliasInChinese;

    /**
     * @description aliasEn
     *
     * @var string
     */
    public $aliasInEnglish;
    protected $_name = [
        'aliasInChinese' => 'aliasInChinese',
        'aliasInEnglish' => 'aliasInEnglish',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->aliasInChinese) {
            $res['aliasInChinese'] = $this->aliasInChinese;
        }
        if (null !== $this->aliasInEnglish) {
            $res['aliasInEnglish'] = $this->aliasInEnglish;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aliasInChinese'])) {
            $model->aliasInChinese = $map['aliasInChinese'];
        }
        if (isset($map['aliasInEnglish'])) {
            $model->aliasInEnglish = $map['aliasInEnglish'];
        }

        return $model;
    }
}
