<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsTermsExtractEaskRequest\extractRules;

use AlibabaCloud\Tea\Model;

class termRules extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $termCategory;
    protected $_name = [
        'description' => 'description',
        'termCategory' => 'termCategory',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->termCategory) {
            $res['termCategory'] = $this->termCategory;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return termRules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['termCategory'])) {
            $model->termCategory = $map['termCategory'];
        }

        return $model;
    }
}
