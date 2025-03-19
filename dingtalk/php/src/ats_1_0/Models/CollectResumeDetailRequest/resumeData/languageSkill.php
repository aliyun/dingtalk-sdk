<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;

use AlibabaCloud\Tea\Model;

class languageSkill extends Model
{
    /**
     * @example 大学英语六级
     *
     * @var string
     */
    public $certificateName;

    /**
     * @example 英语
     *
     * @var string
     */
    public $languageName;
    protected $_name = [
        'certificateName' => 'certificateName',
        'languageName' => 'languageName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->certificateName) {
            $res['certificateName'] = $this->certificateName;
        }
        if (null !== $this->languageName) {
            $res['languageName'] = $this->languageName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return languageSkill
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['certificateName'])) {
            $model->certificateName = $map['certificateName'];
        }
        if (isset($map['languageName'])) {
            $model->languageName = $map['languageName'];
        }

        return $model;
    }
}
