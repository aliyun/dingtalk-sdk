<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class subInstShopInfo extends Model
{
    /**
     * @description 内景照
     *
     * @var string[]
     */
    public $inDoorImages;

    /**
     * @description 外景照
     *
     * @var string[]
     */
    public $outDoorImages;
    protected $_name = [
        'inDoorImages'  => 'inDoorImages',
        'outDoorImages' => 'outDoorImages',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->inDoorImages) {
            $res['inDoorImages'] = $this->inDoorImages;
        }
        if (null !== $this->outDoorImages) {
            $res['outDoorImages'] = $this->outDoorImages;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subInstShopInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['inDoorImages'])) {
            if (!empty($map['inDoorImages'])) {
                $model->inDoorImages = $map['inDoorImages'];
            }
        }
        if (isset($map['outDoorImages'])) {
            if (!empty($map['outDoorImages'])) {
                $model->outDoorImages = $map['outDoorImages'];
            }
        }

        return $model;
    }
}
