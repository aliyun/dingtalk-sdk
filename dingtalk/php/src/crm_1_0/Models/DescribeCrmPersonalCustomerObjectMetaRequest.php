<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DescribeCrmPersonalCustomerObjectMetaRequest extends Model
{
    /**
     * @var string
     */
    public $relationType;
    protected $_name = [
        'relationType' => 'relationType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DescribeCrmPersonalCustomerObjectMetaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }

        return $model;
    }
}
