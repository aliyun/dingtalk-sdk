<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class subInstBasicInfo extends Model
{
    /**
     * @description 名称
     *
     * @var string
     */
    public $subInstName;

    /**
     * @description 别名
     *
     * @var string
     */
    public $aliasName;

    /**
     * @description 类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 机构识别码
     *
     * @var string
     */
    public $mcc;
    protected $_name = [
        'subInstName' => 'subInstName',
        'aliasName'   => 'aliasName',
        'type'        => 'type',
        'mcc'         => 'mcc',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subInstName) {
            $res['subInstName'] = $this->subInstName;
        }
        if (null !== $this->aliasName) {
            $res['aliasName'] = $this->aliasName;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->mcc) {
            $res['mcc'] = $this->mcc;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subInstBasicInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subInstName'])) {
            $model->subInstName = $map['subInstName'];
        }
        if (isset($map['aliasName'])) {
            $model->aliasName = $map['aliasName'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['mcc'])) {
            $model->mcc = $map['mcc'];
        }

        return $model;
    }
}
