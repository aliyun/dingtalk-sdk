<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models;

use AlibabaCloud\Tea\Model;

class TalentV2DeletePersonalityTagRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $tagCode;
    protected $_name = [
        'tagCode' => 'tagCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TalentV2DeletePersonalityTagRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }

        return $model;
    }
}
