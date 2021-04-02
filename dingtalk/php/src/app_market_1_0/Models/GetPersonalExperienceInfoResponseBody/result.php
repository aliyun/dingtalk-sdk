<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetPersonalExperienceInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 主组织corpId
     *
     * @var string
     */
    public $mainCorpId;
    protected $_name = [
        'mainCorpId' => 'mainCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mainCorpId) {
            $res['mainCorpId'] = $this->mainCorpId;
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
        if (isset($map['mainCorpId'])) {
            $model->mainCorpId = $map['mainCorpId'];
        }

        return $model;
    }
}
