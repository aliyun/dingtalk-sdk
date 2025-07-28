<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class VerifyEduOrgCertificationResponseBody extends Model
{
    /**
     * @var bool
     */
    public $certificated;
    protected $_name = [
        'certificated' => 'certificated',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->certificated) {
            $res['certificated'] = $this->certificated;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return VerifyEduOrgCertificationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['certificated'])) {
            $model->certificated = $map['certificated'];
        }

        return $model;
    }
}
