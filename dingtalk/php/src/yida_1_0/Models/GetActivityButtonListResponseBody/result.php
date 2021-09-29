<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityButtonListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description aliasEn
     *
     * @var string
     */
    public $aliasInEnglish;

    /**
     * @description alias
     *
     * @var string
     */
    public $aliasInChinese;
    protected $_name = [
        'aliasInEnglish' => 'aliasInEnglish',
        'aliasInChinese' => 'aliasInChinese',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->aliasInEnglish) {
            $res['aliasInEnglish'] = $this->aliasInEnglish;
        }
        if (null !== $this->aliasInChinese) {
            $res['aliasInChinese'] = $this->aliasInChinese;
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
        if (isset($map['aliasInEnglish'])) {
            $model->aliasInEnglish = $map['aliasInEnglish'];
        }
        if (isset($map['aliasInChinese'])) {
            $model->aliasInChinese = $map['aliasInChinese'];
        }

        return $model;
    }
}
