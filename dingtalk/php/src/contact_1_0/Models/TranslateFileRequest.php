<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class TranslateFileRequest extends Model
{
    /**
     * @example {"#iAEHAqRmaWxlA6h5dW5kaXNrMAT":"导出.xlsx"}
     *
     * @var string[]
     */
    public $medias;

    /**
     * @example 学习手册
     *
     * @var string
     */
    public $outputFileName;

    /**
     * @example fXRUNiSlgfK3e1hzFUSciiJwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'medias'         => 'medias',
        'outputFileName' => 'outputFileName',
        'unionId'        => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->medias) {
            $res['medias'] = $this->medias;
        }
        if (null !== $this->outputFileName) {
            $res['outputFileName'] = $this->outputFileName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TranslateFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['medias'])) {
            $model->medias = $map['medias'];
        }
        if (isset($map['outputFileName'])) {
            $model->outputFileName = $map['outputFileName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
