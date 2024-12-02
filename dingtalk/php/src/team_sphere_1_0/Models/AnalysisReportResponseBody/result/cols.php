<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\AnalysisReportResponseBody\result;

use AlibabaCloud\Tea\Model;

class cols extends Model
{
    /**
     * @var string
     */
    public $baseType;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $theme;
    protected $_name = [
        'baseType' => 'baseType',
        'name'     => 'name',
        'theme'    => 'theme',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->baseType) {
            $res['baseType'] = $this->baseType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->theme) {
            $res['theme'] = $this->theme;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cols
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['baseType'])) {
            $model->baseType = $map['baseType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['theme'])) {
            $model->theme = $map['theme'];
        }

        return $model;
    }
}
