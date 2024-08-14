<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\workExperiences;

use AlibabaCloud\Tea\Model;

class resumePrivacy extends Model
{
    /**
     * @var bool
     */
    public $shieldedCompany;

    /**
     * @var bool
     */
    public $shieldedRelatedCompany;
    protected $_name = [
        'shieldedCompany'        => 'shieldedCompany',
        'shieldedRelatedCompany' => 'shieldedRelatedCompany',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->shieldedCompany) {
            $res['shieldedCompany'] = $this->shieldedCompany;
        }
        if (null !== $this->shieldedRelatedCompany) {
            $res['shieldedRelatedCompany'] = $this->shieldedRelatedCompany;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resumePrivacy
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['shieldedCompany'])) {
            $model->shieldedCompany = $map['shieldedCompany'];
        }
        if (isset($map['shieldedRelatedCompany'])) {
            $model->shieldedRelatedCompany = $map['shieldedRelatedCompany'];
        }

        return $model;
    }
}
