<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchResidentRequest extends Model
{
    /**
     * @var string
     */
    public $residentCropId;

    /**
     * @var string
     */
    public $searchWord;
    protected $_name = [
        'residentCropId' => 'residentCropId',
        'searchWord'     => 'searchWord',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->residentCropId) {
            $res['residentCropId'] = $this->residentCropId;
        }
        if (null !== $this->searchWord) {
            $res['searchWord'] = $this->searchWord;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchResidentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['residentCropId'])) {
            $model->residentCropId = $map['residentCropId'];
        }
        if (isset($map['searchWord'])) {
            $model->searchWord = $map['searchWord'];
        }

        return $model;
    }
}
