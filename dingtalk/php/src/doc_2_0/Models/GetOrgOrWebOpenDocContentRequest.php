<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetOrgOrWebOpenDocContentRequest extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $generateCp;

    /**
     * @example 0
     *
     * @var int
     */
    public $scopeType;

    /**
     * @example markdown
     *
     * @var string
     */
    public $targetFormat;
    protected $_name = [
        'generateCp' => 'generateCp',
        'scopeType' => 'scopeType',
        'targetFormat' => 'targetFormat',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->generateCp) {
            $res['generateCp'] = $this->generateCp;
        }
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }
        if (null !== $this->targetFormat) {
            $res['targetFormat'] = $this->targetFormat;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOrgOrWebOpenDocContentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['generateCp'])) {
            $model->generateCp = $map['generateCp'];
        }
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }
        if (isset($map['targetFormat'])) {
            $model->targetFormat = $map['targetFormat'];
        }

        return $model;
    }
}
