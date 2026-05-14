<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class SubmitExportJobRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $dentryUuid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description This parameter is required.
     *
     * @example docx
     *
     * @var string
     */
    public $targetFormat;
    protected $_name = [
        'dentryUuid' => 'dentryUuid',
        'operatorId' => 'operatorId',
        'targetFormat' => 'targetFormat',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->targetFormat) {
            $res['targetFormat'] = $this->targetFormat;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitExportJobRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['targetFormat'])) {
            $model->targetFormat = $map['targetFormat'];
        }

        return $model;
    }
}
